// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


'use strict';

(function () {
    const amount = document.querySelector('#amount');
    const amountLabel = document.querySelector('label[for="amount"]');

    amount.addEventListener('focus', function () {
        amountLabel.className = 'has-focus';
    }, false);
    amount.addEventListener('blur', function () {
        amountLabel.className = '';
    }, false);
})();
