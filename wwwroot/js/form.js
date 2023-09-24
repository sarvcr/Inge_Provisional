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
    if (step === 3) {
        document.querySelector('#step' + step + ' .btn-success').textContent = 'Enviar';
    } else {
        document.querySelector('#step' + step + ' .btn-success').textContent = 'Siguiente';
    }
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