function reverse(n,arr)
{
    let xd = [];
    for (let index = 0; index < n; index++) {
        const element = arr[index];
        xd[index] = element;       
    }
    let output = "";
    for (let index = xd.length-1; index >=0; index--) {
        const element = xd[index];
        output+=element + " ";       
    }
    console.log(output);
}
reverse(3, [10, 20, 30, 40, 50])