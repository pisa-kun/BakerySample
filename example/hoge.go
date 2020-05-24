package main

import (
	"fmt"

)

func main() {
	fmt.Println(addCross(1, 2))
}

// 足し算と掛け算の結果を返す
func addCross(x int, y int) (add int, cross int) {
	return x + y, x * y
}
