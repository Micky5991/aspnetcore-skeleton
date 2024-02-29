/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ['./**/*.{razor,cshtml,html}'],
    theme: {
    },
    plugins: [
        require("@tailwindcss/typography"),
        require('@tailwindcss/forms')({
            strategy: 'class', // only generate classes
        }),
    ],
}
