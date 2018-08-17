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
var router_1 = require("@angular/router");
var common_1 = require("@angular/common");
var employee_1 = require("../employee");
var data_service_1 = require("../data.service");
var EmployeeDetailComponent = /** @class */ (function () {
    function EmployeeDetailComponent(route, employeeService, location) {
        this.route = route;
        this.employeeService = employeeService;
        this.location = location;
    }
    EmployeeDetailComponent.prototype.ngOnInit = function () {
        this.getEmployee();
    };
    EmployeeDetailComponent.prototype.getEmployee = function () {
        var _this = this;
        var id = +this.route.snapshot.paramMap.get('id');
        this.employeeService.getEmployee(id)
            .subscribe(function (employee) { return _this.employee = employee; });
    };
    EmployeeDetailComponent.prototype.goBack = function () {
        this.location.back();
    };
    EmployeeDetailComponent.prototype.save = function () {
        var _this = this;
        this.employeeService.updateEmployee(this.employee)
            .subscribe(function () { return _this.goBack(); });
    };
    __decorate([
        core_1.Input(),
        __metadata("design:type", employee_1.Employee)
    ], EmployeeDetailComponent.prototype, "employee", void 0);
    EmployeeDetailComponent = __decorate([
        core_1.Component({
            selector: 'app-employee-detail',
            templateUrl: './employee-detail.component.html',
            styleUrls: ['./employee-detail.component.css']
        }),
        __metadata("design:paramtypes", [router_1.ActivatedRoute,
            data_service_1.DataService,
            common_1.Location])
    ], EmployeeDetailComponent);
    return EmployeeDetailComponent;
}());
exports.EmployeeDetailComponent = EmployeeDetailComponent;
//# sourceMappingURL=employee-detail.component.js.map