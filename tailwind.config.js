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
    extend: {},
  },
  plugins: [],
}
