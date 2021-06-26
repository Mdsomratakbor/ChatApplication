var createRoomBtn = document.getElementById('create-room-btn');
var createRoomModal = document.getElementById('create-room-modal');
createRoomBtn.addEventListener('click', () => {
    createRoomModal.classList.add('active');
})
function closeModel() {
    createRoomModal.classList.remove('active');
}
