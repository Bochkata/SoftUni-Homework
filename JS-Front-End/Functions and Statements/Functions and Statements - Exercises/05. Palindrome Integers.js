function solve(nums){
    for (let index = 0; index < nums.length; index++) {
        const element = nums[index];
        if(element===reversedNum(element))
        console.log(`true`);
        else
        console.log(`false`);
    }
    function reversedNum(num) {
        return (
          parseFloat(
            num
              .toString()
              .split('')
              .reverse()
              .join('')
          ) * Math.sign(num)
        )                 
      }
}
solve([123,323,421,121])