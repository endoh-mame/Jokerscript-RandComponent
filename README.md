# Jokerscript-RandComponent

## Overview

Jokerscriptで乱数を生成するプラグイン

## Install

`JOKER_GAME/Plugins`にRandComponent.csを置く

## Usage

```
; 0から10までの乱数を変数testに代入
[rand var="test" min=0 max=10]
{f.test}[p]
; -10から10までの乱数を変数test2に代入
[rand var="test2" min=-10 max=10]
{f.test2}[p]
```

## Licence

MIT
