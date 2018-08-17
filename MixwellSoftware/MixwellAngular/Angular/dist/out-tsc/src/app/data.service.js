"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/common/http");
var of_1 = require("rxjs/observable/of");
var operators_1 = require("rxjs/operators");
var message_service_1 = require("./message.service");
var mock_services_1 = require("./mock-services");
var httpOptions = {
    headers: new http_1.HttpHeaders({ 'Content-Type': 'application/json' })
};
var DataService = /** @class */ (function () {
    function DataService(http, messageService) {
        this.http = http;
        this.messageService = messageService;
        this.employeeUrl = 'api/heroes'; // URL to web api
    }
    /** GET employees from the server */
    DataService.prototype.getServices = function () {
        return mock_services_1.SERVICES;
    };
    /** GET employees from the server */
    DataService.prototype.getEmployees = function () {
        var _this = this;
        return this.http.get(this.employeeUrl)
            .pipe(operators_1.tap(function (employees) { return _this.log("fetched employees"); }), operators_1.catchError(this.handleError('getEmployees', [])));
    };
    /** GET employee by id. Return `undefined` when id not found */
    DataService.prototype.getEmployeeNo404 = function (id) {
        var _this = this;
        var url = this.employeeUrl + "/?id=" + id;
        return this.http.get(url)
            .pipe(operators_1.map(function (employees) { return employees[0]; }), // returns a {0|1} element array
        operators_1.tap(function (h) {
            var outcome = h ? "fetched" : "did not find";
            _this.log(outcome + " employee id=" + id);
        }), operators_1.catchError(this.handleError("getEmployee id=" + id)));
    };
    /** GET employee by id. Will 404 if id not found */
    DataService.prototype.getEmployee = function (id) {
        var _this = this;
        var url = this.employeeUrl + "/" + id;
        return this.http.get(url).pipe(operators_1.tap(function (_) { return _this.log("fetched employee id=" + id); }), operators_1.catchError(this.handleError("getEmployee id=" + id)));
    };
    /* GET employees whose name contains search term */
    DataService.prototype.searchEmployees = function (term) {
        var _this = this;
        if (!term.trim()) {
            // if not search term, return empty employee array.
            return of_1.of([]);
        }
        return this.http.get("api/employee/?name=" + term).pipe(operators_1.tap(function (_) { return _this.log("found employees matching \"" + term + "\""); }), operators_1.catchError(this.handleError('searchEmployees', [])));
    };
    //////// Save methods //////////
    /** POST: add a new employee to the server */
    DataService.prototype.addEmployee = function (employee) {
        var _this = this;
        return this.http.post(this.employeeUrl, employee, httpOptions).pipe(operators_1.tap(function (employee) { return _this.log("added employee w/ id=" + employee.id); }), operators_1.catchError(this.handleError('addEmployee')));
    };
    /** DELETE: delete the employee from the server */
    DataService.prototype.deleteEmployee = function (employee) {
        var _this = this;
        var id = typeof employee === 'number' ? employee : employee.id;
        var url = this.employeeUrl + "/" + id;
        return this.http.delete(url, httpOptions).pipe(operators_1.tap(function (_) { return _this.log("deleted employee id=" + id); }), operators_1.catchError(this.handleError('deleteEmployee')));
    };
    /** PUT: update the employee on the server */
    DataService.prototype.updateEmployee = function (employee) {
        var _this = this;
        return this.http.put(this.employeeUrl, employee, httpOptions).pipe(operators_1.tap(function (_) { return _this.log("updated employee id=" + employee.id); }), operators_1.catchError(this.handleError('updateEmployee')));
    };
    /**
     * Handle Http operation that failed.
     * Let the app continue.
     * @param operation - name of the operation that failed
     * @param result - optional value to return as the observable result
     */
    DataService.prototype.handleError = function (operation, result) {
        var _this = this;
        if (operation === void 0) { operation = 'operation'; }
        return function (error) {
            // TODO: send the error to remote logging infrastructure
            console.error(error); // log to console instead
            // TODO: better job of transforming error for user consumption
            _this.log(operation + " failed: " + error.message);
            // Let the app keep running by returning an empty result.
            return of_1.of(result);
        };
    };
    /** Log a DataService message with the MessageService */
    DataService.prototype.log = function (message) {
        this.messageService.add('DataService: ' + message);
    };
    DataService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.HttpClient,
            message_service_1.MessageService])
    ], DataService);
    return DataService;
}());
exports.DataService = DataService;
//# sourceMappingURL=data.service.js.map