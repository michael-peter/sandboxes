#include <stdio.h>

int sum(int x, int y) {
  int result = x + y;

  return (result);
}

int main(void) {
  int result;

  result = sum(5, 6);
  printf("%d\n", result);

  return (0);
}