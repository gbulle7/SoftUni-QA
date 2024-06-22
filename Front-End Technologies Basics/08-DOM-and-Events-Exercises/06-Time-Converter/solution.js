function attachEventsListeners() {
    let ratios = {
        days: 1,
        hours: 24,
        minutes: 1440,
        seconds: 86400
    };

    let daysInput = document.getElementById('days');
    let hoursInput = document.getElementById('hours');
    let minutesInput = document.getElementById('minutes');
    let secondsInput = document.getElementById('seconds');

    document.querySelector('main').addEventListener('click', convert);

    function convert(event) {
        if (event.target.type == 'button') {
            let input = event.target.parentElement.querySelector('input[type="text"]');

            let inputInDays = Number(input.value) / ratios[input.id];

            let displayDays = inputInDays;
            let displayHours = displayDays * ratios.hours;
            let displayMinutes = displayDays * ratios.minutes;
            let displaySeconds = displayDays * ratios.seconds;

            daysInput.value = displayDays;
            hoursInput.value = displayHours;
            minutesInput.value = displayMinutes;
            secondsInput.value = displaySeconds;
        }
    }
}