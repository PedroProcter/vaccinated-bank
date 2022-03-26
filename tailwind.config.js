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
      gridTemplateColumns: {
        'fill-40': 'repeat(auto-fill, 10rem)',
      },
    },
  },
  plugins: [],
}
