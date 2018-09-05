#!/bin/sh
set -e

services="hierarchy iam iot pas"

# $1 language
echo "language: $1"
# $2 branch
echo "branch: $2"
# $3 files
echo "files: $3"

setup_git() {
  git config --global user.email "deploy@travis-ci.org"
  git config --global user.name "Travis CI"
}

contains() {
    [[ $1 =~ (^|[[:space:]])$2($|[[:space:]]) ]] && exit(0) || exit(1)
}

commit_files() {
  git checkout -b $2

  for i in $( ls $3 ); do
    if contains services $i; then
      cp -rf $3/$i .
      git add -v $i
    fi
  done

  git commit -v -m "Deploy SKF/proto to github.com/SKF/proto.git:$2"
  # git tag "${TRAVIS_TAG}-$1"
}

upload_files() {
  git remote add origin https://${GITHUB_TOKEN}@github.com/SKF/proto.git > /dev/null 2>&1
  git push -v --set-upstream origin $1 
}

setup_git
commit_files $1 $2 $3
# upload_files $2