function integersSum([nums]) {

    nums = nums.split(' ').map(n => Number(n));

    if (nums[0] + nums[1] == nums[2]) {
        console.log(`${Math.min(nums[0], nums[1])} + ${Math.max(nums[0], nums[1])} = ${nums[2]}`);
    } else if (nums[0] + nums[2] == nums[1]) {
        console.log(`${Math.min(nums[0], nums[2])} + ${Math.max(nums[0], nums[2])} = ${nums[1]}`);
    } else if (nums[1] + nums[2] == nums[0]) {
        console.log(`${Math.min(nums[1], nums[2])} + ${Math.max(nums[1], nums[2])} = ${nums[0]}`);
    } else {
        console.log('No');
    }
}
integersSum(['8 15 7']);












