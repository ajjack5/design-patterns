export interface IEmployee {
    completeWorkTask(): boolean;
}

export class Employee implements IEmployee {
    completeWorkTask(): boolean {
        return true;
    }
}

export class Manager implements IEmployee {
    public employees: IEmployee[] = [];

    completeWorkTask(): boolean {
        if (!this.employees?.length) {
            return false;
        }

        this.employees.every(x => x.completeWorkTask());
    }
}


// example
export class EmployeeTaskService {
    constructor() { }

    public doWork(): void {
        const ceo: Manager = new Manager();
        const headOfDepartment: Manager = new Manager();
        const teamLead: Manager = new Manager();

        const juniorEngineer: Employee = new Employee();
        const midEngineer: Employee = new Employee();
        const seniorEngineer: Employee = new Employee();

        ceo.employees.push(headOfDepartment);
        headOfDepartment.employees.push(teamLead);

        teamLead.employees.push(juniorEngineer);
        teamLead.employees.push(midEngineer);
        teamLead.employees.push(seniorEngineer);

        const result = ceo.completeWorkTask();  // true
    }
}