#!/bin/bash -e
# This is meant to be used on OS X only.
export SSHTARGET="ranier@10.3.10.175"
export LOCALDIR="../"
export REMOTEDIR="~/Desktop/UnityBuilds/training_jeremy/"
export BUILDDIR="Builds/iOS/"

cd "$(dirname "$0")"
shell/common_build.sh