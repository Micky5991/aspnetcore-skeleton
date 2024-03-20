const colors = require('tailwindcss/colors');
const defaultTheme = require('tailwindcss/defaultTheme');

/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ['./**/*.{razor,cshtml,html}'],
    theme: {
        extend: {
            colors: {
                primary: colors.blue,
            },
            fontFamily: {
                'sans': ['"Rubik"', ...defaultTheme.fontFamily.sans],
            },
        }
    },
    plugins: [
        require("@tailwindcss/typography"),
        require('@tailwindcss/forms')({
            strategy: 'class', // only generate classes
        }),
    ],
}
