#!/bin/sh
set -e

# $1 language
# $2 branch
# $3 files

setup_git() {
  git config --global user.email "deploy@travis-ci.org"
  git config --global user.name "Travis CI"
}

commit_files() {
  git checkout -b $2
  git add $3
  git commit --message "Deploy SKF/proto to github.com/SKF/proto.git:$2"
  git tag "${TRAVIS_TAG}-$1"
}

upload_files() {
  git remote add origin https://${GITHUB_TOKEN}@github.com/SKF/proto.git > /dev/null 2>&1
  git push --quiet --set-upstream origin $1 
}

setup_git
commit_files $1 $2 $3
upload_files $2