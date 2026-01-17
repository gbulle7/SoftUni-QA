function sort(arr) {
    arr.sort((a, b) => a - b);
    const sortedArr = [];
    
    let left = 0;
    let right = arr.length - 1;
    
    while (left <= right) {
        if (left === right) {
            sortedArr.push(arr[left]); // Push the last middle element
        } else {
            sortedArr.push(arr[left]); // Push the smallest
            sortedArr.push(arr[right]); // Push the largest
        }
        left++;
        right--;
    }
    
    return sortedArr;
}