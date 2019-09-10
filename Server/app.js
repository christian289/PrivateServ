'use strict';
var debug = require('debug');
var express = require('express');
var path = require('path');
var favicon = require('serve-favicon');
var logger = require('morgan');
var cookieParser = require('cookie-parser');
var bodyParser = require('body-parser');

var routes = require('./routes/index'); // routes 폴더에 추가하면 여기도 코드 추가
var users = require('./routes/users'); // routes 폴더에 추가하면 여기도 코드 추가
var chatrooms = require('./routes/chatroom'); // routes 폴더에 추가하면 여기도 코드 추가

var app = express();

// view engine setup
app.set('views', path.join(__dirname, 'views')); // 이 코드 덕분에 index.js에서 render()호출 시 첫번째 인자에 파일명만 써도 매칭됨.
app.set('view engine', 'pug'); //views의 파일들이 pug 문법을 따름.

// uncomment after placing your favicon in /public
//app.use(favicon(__dirname + '/public/favicon.ico'));
app.use(logger('dev'));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));

app.use('/', routes); // routes 폴더에 추가하면 여기도 코드 추가
app.use('/users', users); // routes 폴더에 추가하면 여기도 코드 추가
app.use('/chatrooms', chatrooms); // routes 폴더에 추가하면 여기도 코드 추가

// catch 404 and forward to error handler
app.use(function (req, res, next) {
    var err = new Error('Not Found');
    err.status = 404;
    next(err);
});

// error handlers

// development error handler
// will print stacktrace
if (app.get('env') === 'development') {
    app.use(function (err, req, res, next) {
        res.status(err.status || 500);
        res.render('error', {
            message: err.message,
            error: err
        });
    });
}

// production error handler
// no stacktraces leaked to user
app.use(function (err, req, res, next) {
    res.status(err.status || 500);
    res.render('error', {
        message: err.message,
        error: {}
    });
});

app.set('port', process.env.PORT || 3000);

var server = app.listen(app.get('port'), function () {
    debug('Express server listening on port ' + server.address().port);
});
