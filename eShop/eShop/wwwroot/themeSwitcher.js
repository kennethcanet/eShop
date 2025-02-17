window.themeManager = {
    setTheme: (theme) => {
        document.documentElement.setAttribute("data-bs-theme", theme);
        localStorage.setItem("theme", theme);
    },

    getTheme: () => {
        return localStorage.getItem("theme") || "light";
    }
};