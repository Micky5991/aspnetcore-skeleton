const colors = require('tailwindcss/colors');

/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ['./**/*.{razor,cshtml,html}'],
    theme: {
        extend: {
            colors: {
                primary: colors.blue,
            }
        }
    },
    plugins: [
        require("@tailwindcss/typography"),
        require('@tailwindcss/forms')({
            strategy: 'class', // only generate classes
        }),
    ],
}
