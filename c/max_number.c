#include <stdio.h>
#include <stdlib.h>

int main(int args_count, char **args_list) {
  int max_number;
  int *numbers = malloc(sizeof(int) * (args_count - 1));

  if (!numbers) {
    return (1);
  }

  for (int i = 0; i < (args_count - 1); i++) {
    numbers[i] = args_list[1 + i];
  }

  max_number = numbers[0];
  for (int i = 0; i < (args_count - 1); i++) {
    if (numbers[i] > max_number) {
      max_number = numbers[i];
    }
  }

  printf("Maximum number is %d\n", max_number);

  free(numbers);

  return (0);
}