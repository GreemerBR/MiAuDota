let config = require('./config');

// See: https://github.com/postcss/postcss-loader#usage
let postcssConfig = {
  plugins: [
    require('autoprefixer')(),
    //require('stylefmt')
  ]
};

if (config.production) {
  postcssConfig.plugins.push(
    require('postcss-csso')({
      restructure: false,
      debug: true
    })
  );
}

module.exports = postcssConfig;
