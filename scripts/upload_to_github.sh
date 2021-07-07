#!/bin/sh
set -e

# $1 language
echo "language: $1"
# $2 branch
echo "branch: $2"
# $3 files
echo "files: $3"
# $4 tag name
echo "tag name: $4"
# $5 github token

setup_git() {
  git config --global user.name "GitHub Actions"
  git remote set-url origin https://$5@github.com/SKF/proto.git > /dev/null 2>&1
}

commit_files() {
  git fetch --all
  git checkout $2
  git rm -rf --ignore-unmatch .

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

  git commit -v --allow-empty -m "Deploy SKF/proto to github.com/SKF/proto.git:$2"
  git tag "$4-$1"
}

upload_files() {
  git push -v
  git push --tag
}

setup_git
commit_files $1 $2 $3
upload_files $2
