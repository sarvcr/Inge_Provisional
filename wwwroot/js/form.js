function nextStep(step) {
    // Si es el �ltimo paso, limpiar campos
    if (step > 7) {
        clearFields();
        return;
    }

    // Oculta todos los pasos
    document.querySelectorAll('.form-step').forEach(el => el.style.display = 'none');
    // Muestra el paso deseado
    document.getElementById('step' + step).style.display = 'block';
    // Actualiza el indicador de progreso
    updateProgress(step);
    // Cambia el texto del bot�n en el �ltimo paso
    if (step === 7) {
        document.querySelector('#step' + step + ' .btn-success').textContent = 'Enviar';
    } else {
        document.querySelector('#step' + step + ' .btn-success').textContent = 'Siguiente';
    }
}

function prevStep(step) {
    nextStep(step); // Reutiliza la funci�n nextStep
}

function updateProgress(step) {
    document.querySelectorAll('.progress-indicator .circle').forEach((el, index) => {
        if (parseInt(el.getAttribute('data-step')) === step) {
            el.classList.remove('inactive-circle');
            el.classList.add('active-circle');
        } else {
            el.classList.remove('active-circle');
            el.classList.add('inactive-circle');
        }
    });
}
function goToStep(step) {
    // Oculta todos los pasos
    document.querySelectorAll('.form-step').forEach(el => el.style.display = 'none');
    // Muestra el paso deseado
    document.getElementById('step' + step).style.display = 'block';
    // Actualiza el indicador de progreso
    updateProgress(step);
    // Cambia el texto del bot�n en el �ltimo paso
    if (step === 7) { // Ajusta este n�mero si tienes m�s pasos
        document.querySelector('#step' + step + ' .btn-success').textContent = 'Enviar';
    } else {
        document.querySelector('#step' + step + ' .btn-success').textContent = 'Siguiente';
    }
}



function clearFields() {
    document.querySelectorAll('input, select').forEach(el => {
        if (el.type === 'text' || el.type === 'email') {
            el.value = '';
        } else if (el.type === 'checkbox') {
            el.checked = false;
        } else if (el.tagName === 'SELECT') {
            el.selectedIndex = 0;
        }
    });
}   



//PRIMERA PARTE DEL FORMULARIO
function buscarPorNumeroDePlaza() {
    // Aqu� se realizar� la solicitud AJAX para buscar por n�mero de plaza
    // Si la respuesta es OK, se autocompletan los campos
    // Si hay un error, se muestra un mensaje
}

function cargarTrabajadoresPorCargo() {
    // Aqu� se realizar� la solicitud AJAX para obtener los trabajadores por cargo
    // Se llenar� el select de encargado con las opciones recibidas
}

function obtenerNumeroDePlaza() {
    // Aqu� se realizar� la solicitud AJAX para obtener el n�mero de plaza
    // Se autocompletar� el campo de n�mero de plaza
}

function validarYContinuar() {
    // Aqu� se realizar� la solicitud AJAX para validar la informaci�n
    // Si la informaci�n es correcta, se pasa al siguiente paso
    // Si hay un error, se muestra un mensaje
    nextStep(2);
}

// Funci�n para mostrar u ocultar el campo de texto seg�n la selecci�n del paso #5
function toggleAfectaObjetivo() {
    var impactoSelect = document.getElementById("impacto");
    var afectaObjetivoDiv = document.getElementById("afecta-objetivo");

    if (impactoSelect.value === "si") {
        afectaObjetivoDiv.style.display = "block";
    } else {
        afectaObjetivoDiv.style.display = "none";
    }
}
var impactoSelect = document.getElementById("impacto");
impactoSelect.addEventListener("change", toggleAfectaObjetivo);
toggleAfectaObjetivo();

// Funci�n para mostrar u ocultar el campo de valor de activos seg�n la selecci�n del paso #7
function toggleValorActivos() {
    var gestionaActivosSelect = document.getElementById("gestiona-activos");
    var valorActivosDiv = document.getElementById("valor-activos");

    if (gestionaActivosSelect.value === "si") {
        valorActivosDiv.style.display = "block";
    } else {
        valorActivosDiv.style.display = "none";
    }
}
var gestionaActivosSelect = document.getElementById("gestiona-activos");
gestionaActivosSelect.addEventListener("change", toggleValorActivos);
toggleValorActivos();