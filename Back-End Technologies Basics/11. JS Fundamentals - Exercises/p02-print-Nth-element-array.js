function solve(arr, next) {
    newArr = [];
    for (let i = 0; i < arr.length; i+=next) {
        newArr.push(arr[i]);
    }
    return newArr;
}