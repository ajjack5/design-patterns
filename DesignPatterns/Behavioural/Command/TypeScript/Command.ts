export interface ICommand {
    execute(): string;
}

export class Command1 implements ICommand {
    public constructor (private _businessLogicService: BusinessLogicService, private _instructions: string) { }

    public execute(): string
    {
        var commandString = "[Executing Command1]";
        return `${this._instructions}${commandString}${this._businessLogicService.someSpecificbusinessLogic1()}`;
    }
}

export class Command2 implements ICommand {
    public constructor(private _businessLogicService: BusinessLogicService, private _instructions: string) { }

    public execute(): string {
        var commandString = "[Executing Command2]";
        return `${this._instructions}${commandString}${this._businessLogicService.someSpecificbusinessLogic3()}`;
    }
}

export class BusinessLogicService {
    public someSpecificbusinessLogic1(): string
    {
        return "[SomeSpecificbusinessLogic1]";
    }

    public someSpecificbusinessLogic2(): string
    {
        return "[SomeSpecificbusinessLogic2]";
    }

    public someSpecificbusinessLogic3(): string
    {
        return "[SomeSpecificbusinessLogic3]";
    }
}


export class Invoker {
    public invokeCommand(command: ICommand): string
    {
        return command.execute();
    }
}

// example
export class SomeService {
    constructor(private _businessLogicService: BusinessLogicService) { }

    public doSomething(): void {
        const command: ICommand = new Command2(this._businessLogicService, 'additional command requirements go in here for example');

        const invoker: Invoker = new Invoker();
        const result: string = invoker.invokeCommand(command);

        // returns command invoked result for example
        // this pattern plays nicely with mediator
    }
}