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
  git remote set-url origin https://${GITHUB_TOKEN}@github.com/kulbhushan-skf/proto.git > /dev/null 2>&1
}

commit_files() {
  git fetch --all
  git checkout $2
  git rm -rf --ignore-unmatch .

  cp -rf $3/common .
  git add -v common

  for service in $( ls $3 ); do
    if [[ ${SERVICES} =~ (^|[[:space:]])$service($|[[:space:]]) ]]; then
      cp -rf $3/$service .
      git add -v $service
    fi
  done

  if [ -f "$3/go.mod" ]; then
    cp $3/go.{mod,sum} .
    git add go.{mod,sum}
  fi

  git commit -v --allow-empty -m "Deploy kulbhushan-skf/proto to github.com/kulbhushan-skf/proto.git:$2"
  git tag "${TRAVIS_TAG}-$1"
}

upload_files() {
  git push -v
  git push --tag
}

setup_git
commit_files $1 $2 $3
upload_files $2
