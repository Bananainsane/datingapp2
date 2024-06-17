function initializeSwipeListener() {
    var element = document.getElementById('profileElementId');
    var startX, startY, distX, distY;

    if (element) {
        element.addEventListener(
            'touchstart',
            function (e) {
                console.log('Touch start detected');
                var touchobj = e.changedTouches[0];
                startX = touchobj.pageX;
                startY = touchobj.pageY;
                console.log('startX:', startX, 'startY:', startY);
            },
            false
        );

        element.addEventListener(
            'touchmove',
            function (e) {
                console.log('Touch move detected');
                e.preventDefault(); // Prevent scrolling when inside DIV
            },
            false
        );

        element.addEventListener(
            'touchend',
            function (e) {
                console.log('Touch end detected');
                var touchobj = e.changedTouches[0];
                distX = touchobj.pageX - startX;
                distY = touchobj.pageY - startY;
                console.log('distX:', distX, 'distY:', distY);
                handleSwipe(distX, distY);
            },
            false
        );
    } else {
        console.log('Element not found: profileElementId');
    }

    function handleSwipe(distX, distY) {
        if (Math.abs(distX) > 50 && Math.abs(distY) < 100) {
            // Horizontal swipe
            if (distX > 0) {
                console.log('Swipe Right');
                DotNet.invokeMethodAsync('DatingApp', 'SwipeRight').catch(
                    (err) => console.error(err)
                );
            } else {
                console.log('Swipe Left');
                DotNet.invokeMethodAsync('DatingApp', 'SwipeLeft').catch(
                    (err) => console.error(err)
                );
            }
        } else {
            console.log('Swipe did not meet threshold');
        }
    }
}

document.addEventListener('DOMContentLoaded', function () {
    initializeSwipeListener();
});
