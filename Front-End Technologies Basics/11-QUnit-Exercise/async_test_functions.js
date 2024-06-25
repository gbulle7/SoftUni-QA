async function fetchData(url) {
    let result = await fetch(url)
                    .then(response => {
                        if (response.ok) {
                            return response.json();
                        }
                    })
                    .catch(error => "fetch failed");
                    // .catch(error => `${errormessage}`);

    return result;
}

async function fake_delay(milliseconds) {
    return new Promise(resolve => setTimeout(resolve, milliseconds));
}

module.exports = {
    fetchData,
    fake_delay
}