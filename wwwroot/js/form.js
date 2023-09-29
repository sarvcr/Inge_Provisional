function nextStep(step) {
    // Si es el último paso, limpiar campos
    if (step > 6) {
        clearFields();
        return;
    }

    // Oculta todos los pasos
    document.querySelectorAll('.form-step').forEach(el => el.style.display = 'none');
    // Muestra el paso deseado
    document.getElementById('step' + step).style.display = 'block';
    // Actualiza el indicador de progreso
    updateProgress(step);
    // Cambia el texto del botón en el último paso
    if (step === 6) {
        document.querySelector('#step' + step + ' .btn-success').textContent = 'Enviar';
    } else {
        document.querySelector('#step' + step + ' .btn-success').textContent = 'Siguiente';
    }
}
function toggleTextBox() {
    var selectElement = document.getElementById('responsibility');
    var additionalInfoDiv = document.getElementById('additionalInfo');
    var additionalText = document.getElementById('additionalText');

    if (selectElement.value === "si") {
        additionalInfoDiv.style.display = "block";
        additionalText.value = "proyecto a, plan z...";
    } else {
        additionalInfoDiv.style.display = "none";
        additionalText.value = "";
    }

    additionalText.addEventListener('input', function clearText() {
        additionalText.removeEventListener('input', clearText);
        additionalText.value = "";
    });
}
function prevStep(step) {
    nextStep(step); // Reutiliza la función nextStep
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
    // Cambia el texto del botón en el último paso
    if (step === 3) { // Ajusta este número si tienes más pasos
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
    // Aquí se realizará la solicitud AJAX para buscar por número de plaza
    // Si la respuesta es OK, se autocompletan los campos
    // Si hay un error, se muestra un mensaje
}

function cargarTrabajadoresPorCargo() {
    // Aquí se realizará la solicitud AJAX para obtener los trabajadores por cargo
    // Se llenará el select de encargado con las opciones recibidas
}

function obtenerNumeroDePlaza() {
    // Aquí se realizará la solicitud AJAX para obtener el número de plaza
    // Se autocompletará el campo de número de plaza
}

function validarYContinuar() {
    // Aquí se realizará la solicitud AJAX para validar la información
    // Si la información es correcta, se pasa al siguiente paso
    // Si hay un error, se muestra un mensaje
    nextStep(2);
}
