// async function fetchDataWithErrorHandling() {
//     try {
//         const response = await fetch("https://swapi.dev/api/people/1");
//         const data = await response.json();
//         console.log(data);
//         console.log(data2) // not defined

//     } catch (error) {
//         console.log('Error while fetching data:', error);
//     }
// }

async function fetchDataWithErrorHandling() {
    try {
        const response = await fetch("https://swapi.dev/api/people/9999"); // 404
        if (!response.ok) throw new Error("Network response is not ok");

        const data = await response.json();
        console.log(data);

    } catch (error) {
        console.log('Error while fetching data:', error);   // Not covering server/network/cors errors unless if !response.ok to throw an error
    }
}