window.addSwipeListener = function(elementId, dotNetHelper) {
    var element = document.getElementById(elementId);
    if (!element) {
        console.error("Element not found:", elementId);
        return; // Exit if element is not found to avoid errors
    }

    var startX, startY, currentX, currentY, distX;

    function handleGesture() {
        var threshold = 100; // Minimum distance traveled to be considered swipe
        if (Math.abs(distX) >= threshold) {
            if (distX > 0) {
                dotNetHelper.invokeMethodAsync('SwipeRight');
            } else {
                dotNetHelper.invokeMethodAsync('SwipeLeft');
            }
            element.style.transform = ''; // Reset transformation
            element.remove(); // Optionally remove the element
        } else {
            element.style.transform = 'translate(0, 0)';
        }
    }

    // Touch Events
    element.addEventListener('touchstart', function(e) {
        var touchobj = e.changedTouches[0];
        startX = touchobj.pageX;
        startY = touchobj.pageY; // startY is recorded but not used
        e.preventDefault();
    }, false);

    element.addEventListener('touchmove', function(e) {
        var touchobj = e.changedTouches[0];
        currentX = touchobj.pageX;
        currentY = touchobj.pageY; // currentY is recorded but not used
        distX = currentX - startX;
        element.style.transform = `translate(${distX}px) rotate(${distX / 10}deg)`;
        e.preventDefault();
    }, false);

    element.addEventListener('touchend', function(e) {
        handleGesture();
        e.preventDefault();
    }, false);

    // Mouse Events
    element.addEventListener('mousedown', function(e) {
        console.log("mousedown");

        startX = e.pageX;
        startY = e.pageY; // startY is recorded but not used
        e.preventDefault();
    }, false);

    element.addEventListener('mousemove', function(e) {
        if (e.buttons === 1) {
            currentX = e.pageX;
            currentY = e.pageY; // currentY is recorded but not used
            distX = currentX - startX;
            element.style.transform = `translate(${distX}px) rotate(${distX / 10}deg)`;
        }
        e.preventDefault();
    }, false);

    element.addEventListener('mouseup', function(e) {
        handleGesture();
        e.preventDefault();
    }, false);
}
