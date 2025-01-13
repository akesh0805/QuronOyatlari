window.audioPlayer = {
    setupAudioEndedHandler: function (audioElement, dotNetReference) {
        audioElement.addEventListener('ended', function () {
            dotNetReference.invokeMethodAsync('OnAudioEnded');
        });
    },

    play: function (audioElement) {
        audioElement.play();
    },

    pause: function (audioElement) {
        audioElement.pause();
    },

    setCurrentTime: function (audioElement, time) {
        audioElement.currentTime = time;
    }
};