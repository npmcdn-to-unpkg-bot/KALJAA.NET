'use strict'

var gulp = require("gulp");
var concat = require("gulp-concat")
var sourcemaps = require('gulp-sourcemaps');
var mainBowerFiles = require('main-bower-files');
var gulpFilter = require('gulp-filter');
var gulpDebug = require('gulp-debug');
var gulpLess = require('gulp-less');
var plumber = require('gulp-plumber');

var path = require('path');
var child_process = require('child_process');

var ts = require('gulp-typescript');

var onError = (err) => {
    console.log(err);
}

gulp.task('build:ts', function () {
  let tsConfig = require('./tsconfig.json');
    
  return gulp
    .src([
      './typings/browser.d.ts',
      './wwwroot/app/*.ts'
    ])
    .pipe(gulpDebug({title: "(ts)"}))
    .pipe(ts(tsConfig.compilerOptions))
    .pipe(gulp.dest('wwwroot/app'));
});

gulp.task('watch', () => {
    gulp.start('build:ts');
    gulp.watch('./wwwroot/app/**/*.ts', ['build:ts']);
});