angularFormsApp.factory('efService',
    function(){
        return {
            employee: {
                fullName: "Henry Wang",
                notes: "The ideal employee. Just don't touch his red staple",
                department: "Administration",
                perkCar: true,
                perkStock: false,
                perkSixWeeks: true,
                payrollType: "none"
            }
        }
    }
)