GetBoundingClientRect = (element, parm) => { return element.getBoundingClientRect(); };

function gameLoop(timeStamp) {
    window.requestAnimationFrame(gameLoop);
    game.instance.invokeMethodAsync('GameLoop');
}

function onResize() {
    if (!window.game.canvas)
        return;

    game.canvas.width = window.innerWidth;
    game.canvas.height = window.innerHeight;

    game.instance.invokeMethodAsync('OnResize', game.canvas.width, game.canvas.height);
}

window.gameWindowResize = (instance) => {
    onResize();
};

window.initCanvas = (instance) => {
    var canvasContainer = document.getElementById('canvasContainer'),
        canvases = canvasContainer.getElementsByTagName('canvas') || [];
    window.game = {
        instance: instance,
        canvas: canvases.length ? canvases[0] : null
    };

    if (window.game.canvas) {
        window.game.canvas.onkeydown = (e) => {
            game.instance.invokeMethodAsync('OnKeyDown', e.keyCode);
        };
        window.game.canvas.onkeyup = (e) => {
            game.instance.invokeMethodAsync('OnKeyUp', e.keyCode);
        };
        window.game.canvas.onblur = (e) => {
            e
            window.game.canvas.focus();
        };
        window.game.canvas.onmousedown = (e) => {
            game.instance.invokeMethodAsync('OnMouseDown', e.button, e.x, e.y);
        };
        window.game.canvas.onmouseup = (e) => {
            game.instance.invokeMethodAsync('OnMouseUp', e.button, e.x, e.y);
        };
        window.game.canvas.tabIndex = 0;
        window.game.canvas.focus();
    }

    onResize();
    window.addEventListener("resize", onResize);

    window.requestAnimationFrame(gameLoop);

    console.log('Init Complete');

    return {
        Width: window.game.canvas.width,
        Height: window.game.canvas.height
    };
};