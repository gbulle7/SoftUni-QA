async function getUserInput(promptMessage) {
    return new Promise(resolve => {
        const input = prompt(promptMessage);
        resolve(input);
    });
}

async function startCountdown() {
    const userInput = await getUserInput("Enter the number of seconds for the countdown:");
    let countdown = parseInt(userInput);

    if (!Number.isInteger(countdown)) {
        console.log("Please enter a valid number of seconds.");
        return;
    }

    console.log(`Countdown started from ${countdown} seconds`);
    const countdownInterval = setInterval(async () => {
        console.log(`Time left: ${countdown} seconds`);
        countdown--;
        if (countdown == 0) {
            clearInterval(countdownInterval);
            console.log("Countdown finished");
            await saveRemainingTime(countdown);
        }
    }, 1000);
}

function saveRemainingTime(time) {
    return new Promise((resolve) => {
        setTimeout(() => {
            console.log(`Remaining time saved: ${time} seconds`);
            resolve();
        }, 500);
    });
}