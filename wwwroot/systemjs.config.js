System.config({
    map: {
        'app' : 'app',
        'rxjs': 'node_modules/rxjs',
        '@angular'                    : 'node_modules/@angular',
      },
      packages: {
        'app'                              : {main: 'main.js', defaultExtension: 'js'},
        'rxjs'                             : {main: 'index.js'},
        '@angular/core'                    : {main: 'index.js'},
        '@angular/common'                  : {main: 'index.js'},
        '@angular/compiler'                : {main: 'index.js'},
        '@angular/router'                  : {main: 'index.js'},
        '@angular/platform-browser'        : {main: 'index.js'},
        '@angular/platform-browser-dynamic': {main: 'index.js'}
      }
});