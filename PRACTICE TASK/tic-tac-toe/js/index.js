let playerText = document.getElementById('playerText')
let restartBtn = document.getElementById('restartBtn')
let boxes = Array.from(document.getElementsByClassName('box'))


const O_TEXT = "O"
const X_TEXT = "X"
let currentPlayer = X_TEXT
let spaces = Array(9).fill(null)

const startGame = () => {
    boxes.forEach(box => box.addEventListener('click', boxClicked))

}


function boxClicked(e) {
    const id = e.target.id

    if (!spaces[id]) {
        spaces[id] = currentPlayer
        e.target.innerText = currentPlayer

        if (playerHasWon() !== false) {


            playerText.innerHTML = `${currentPlayer} has won !`
            document.getElementById('gameboard').style.display = 'none';
            document.getElementById('restartBtn').innerHTML = 'Start again !';



            return
        }

        currentPlayer = currentPlayer == X_TEXT ? O_TEXT : X_TEXT
    }
}

const winningCombos = [
    [0, 1, 2],
    [3, 4, 5],
    [6, 7, 8],
    [0, 3, 6],
    [1, 4, 7],
    [2, 5, 8],
    [0, 4, 8],
    [2, 4, 6]
]

function playerHasWon() {
    for (const condition of winningCombos) {
        let [a, b, c] = condition

        if (spaces[a] && (spaces[a] == spaces[b] && spaces[a] == spaces[c])) {

            return [a, b, c]
        }

    }


    return false
}

restartBtn.addEventListener('click', restart)

function restart() {
    document.getElementById('gameboard').style.display = 'flex';
    document.getElementById('restartBtn').innerHTML = 'Restart';

    spaces.fill(null)

    boxes.forEach(box => {
        box.innerText = ''
        box.style.backgroundColor = ''
    })

    playerText.innerHTML = ''

    currentPlayer = X_TEXT
}

startGame()