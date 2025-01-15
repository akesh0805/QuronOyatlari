window.audioPlayer = {
    setupAudioEndedHandler: function (audioElement, dotNetReference) {
        audioElement.addEventListener('ended', function () {
            dotNetReference.invokeMethodAsync('OnAudioEnded');
        });
    },

    play: function (audioElement) {
        console.log('audio play called');
        audioElement.play();
    },
    
    
        pause: function (audioElement) {
            audioElement.pause();
        },
    
        setCurrentTime: function (audioElement, time) {
            audioElement.currentTime = time;
        },
    load: function (audioElement) {
        console.log('audio load called');
        audioElement.load();
    }
};
