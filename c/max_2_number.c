#include <stdio.h>

int main(void) {
  int max_number;
  int numbers[] = {21, 18};

  max_number = numbers[0] > numbers[1] ? numbers[0] : numbers[1];

  printf("Maximum is %d\n", max_number);

  return (0);
}