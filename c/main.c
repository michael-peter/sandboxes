#include <stdio.h>
#include <string.h>

typedef char string[];

int main(int argc, char *argv[]) {
  string name = "Michael";
  // if (argc < 2) {
  //   printf("Please provide an argument \n");
  //   return 1;
  // }
  // printf("hello world %s \n", argv[1]);
  // return 0;
  printf("name here %s\n", name);
}