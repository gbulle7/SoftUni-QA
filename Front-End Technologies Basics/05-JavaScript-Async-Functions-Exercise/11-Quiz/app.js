async function startQuiz() {
    console.log("Quiz started");
    let finalScore = 0
    for (let index = 0; index < questions.length; index++) {
        const {question, answers, correct} = questions[index];
        const userInput = await askQuestion(question, answers);
        if (userInput == correct)
            {
                finalScore++;
                console.log("Correct!")
            } else {
                console.log("Wrong!");
            }
    }
    console.log(`\nYou scored ${finalScore} out of ${questions.length}.`);
}

function askQuestion(question, answers)
{
    return new Promise(function(resolve, reject) {
        let message = question + '\n';
        // answers.forEach(function(answer, index) {
        //     message += `${index}) ${answer}\n`;
        // })
        answers.forEach((answer, index) => message += `${index + 1}) ${answer}\n`);
        const userInput = prompt(message);
        resolve(parseInt(userInput) - 1);
    });
}

const questions = [
    {
        question: "What is 2 + 2?",
        answers: ["3", "4", "5"],
        correct: 1
    },
    {
        question: "What is the capital of France?",
        answers: ["Berlin", "Madrid", "Paris"],
        correct: 2
    },
    {
        question: "What is the square root of 16?",
        answers: ["4", "5", "6"],
        correct: 0
    }
];

// window.startQuiz = startQuiz;