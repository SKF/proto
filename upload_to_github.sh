#!/bin/sh
set -e

# $1 language
echo "language: $1"
# $2 branch
echo "branch: $2"
# $3 files
echo "files: $3"

setup_git() {
  git config --global user.email "deploy@travis-ci.org"
  git config --global user.name "Travis CI"
  git remote set-url origin https://${GITHUB_TOKEN}@github.com/SKF/proto.git > /dev/null 2>&1
}

commit_files() {
  # git fetch --all
  # git branch -a
  git checkout -b $2 --track remotes/origin/$2
  git rm -rf .

  for i in $( ls $3 ); do
    if [[ ${DIRS} =~ (^|[[:space:]])$i($|[[:space:]]) ]]; then
      cp -rf $3/$i .
      git add -v $i
    fi
  done

  git commit -v --allow-empty -m "Deploy SKF/proto to github.com/SKF/proto.git:$2"
  # git tag "${TRAVIS_TAG}-$1"
}

upload_files() {
  git push -v
  git push --tag
}

setup_git
commit_files $1 $2 $3
# upload_files $2