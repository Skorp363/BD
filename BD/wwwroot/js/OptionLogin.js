const form = document.querySelector(".login-form");
const errorContainer = document.querySelector(".error-message");
const submitButton = form.querySelector("button[type='submit']");

// Получаем ссылки на поля формы один раз
const usernameField = form.querySelector("input[name='Username']");
const passwordField = form.querySelector("input[name='PasswordHash']");

form.addEventListener("submit", async (e) => {
    e.preventDefault();

    const username = usernameField.value.trim();
    const password = passwordField.value;

    clearErrorMessages();
    toggleSubmitButton(true, "Вход...");

    try {
        const response = await fetch("/login", {
            method: "POST",
            headers: {
                "Accept": "application/json",
                "Content-Type": "application/json",
            },
            body: JSON.stringify({
                Username: username,
                PasswordHash: password,
            }),
        });

        if (response.ok) {
            window.location.href = "/";
        } else {
            const error = await response.json();
            const errorMessages = error.errors || [error.message];
            displayErrors(errorMessages);
        }
    } catch (err) {
        displayErrors(["Произошла ошибка. Проверьте интернет-соединение или повторите попытку позже."]);
    } finally {
        toggleSubmitButton(false, "Войти");
    }
});

// Управление кнопкой отправки
function toggleSubmitButton(disabled, text) {
    submitButton.disabled = disabled;
    submitButton.textContent = text;
}

// Отображение ошибок
function displayErrors(messages) {
    clearErrorMessages();

    messages.forEach((msg, index) => {
        const errorItem = document.createElement("div");
        errorItem.textContent = `${index + 1}. ${msg}`;
        Object.assign(errorItem.style, {
            color: "#fff",
            backgroundColor: "#c0392b",
            fontSize: "15px",
            padding: "15px",
            borderRadius: "8px",
            margin: "0",
            border: "2px solid #e74c3c",
            boxShadow: "0 4px 12px rgba(0, 0, 0, 0.3)"
        });
        errorContainer.appendChild(errorItem);
    });

    errorContainer.style.display = "block";
}

// Очистка ошибок
function clearErrorMessages() {
    errorContainer.innerHTML = "";
    errorContainer.style.display = "none";
}
