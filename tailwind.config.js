module.exports = {
  mode: 'jit',
  content: [],
  purge: {
    enabled: true,
    content: [
      './**/*.html',
      './**/*.razor'
    ],
  },
  theme: {
    extend: {
      colors: {
        'green-100': '#A7C0AA',
      },
    },
  },
  plugins: [],
}
