#!/bin/sh
echo -ne '\033c\033]0;first 2d game\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/first 2d game.x86_64" "$@"
