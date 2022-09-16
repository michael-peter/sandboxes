function search(nums: number[], target: number): number {
  let lower = 0;
  let upper = nums.length - 1;
  let loops = 0;

  while (lower <= upper) {
    const middle = lower + Math.floor((upper - lower) / 2);

    if (target === nums[middle]) {
      console.log(`took ${loops} loops!`);
      return middle;
    }

    if (target > nums[middle]) {
      lower = middle + 1;
    } else {
      upper = middle - 1;
    }

    loops++;
  }

  console.log(`took ${loops} loops!`);
  return -1;
}

const numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15];

console.log(search(numbers, 7));
