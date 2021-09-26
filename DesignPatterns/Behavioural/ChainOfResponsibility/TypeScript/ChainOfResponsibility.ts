export interface IHandler {
    handle(flag: boolean): number;
}

export abstract class BaseHandler implements IHandler {
    protected _next: IHandler;

    protected constructor(nextHandler: IHandler) {
        this._next = nextHandler;
    }

    public handle(flag: boolean): number
    {
        if (this._next != null) {
            return this._next.handle(flag);
        }

        return 0;
    }
}

export class AfterHandler extends BaseHandler {
    constructor(nextHandler: IHandler) {
        super(nextHandler);
    }

    public handle(flag: boolean): number {
        let result: number = 3;
        let nextResult: number = 0;

        if (this._next != null && flag == true) {
            nextResult = this._next.handle(flag);
        } else {
            super.handle(flag);
        }

        return result + nextResult;
    }
}

export class BeforeHandler extends BaseHandler {
    constructor(nextHandler: IHandler) {
        super(nextHandler);
    }

    public handle(flag: boolean): number {
        let result: number = 42;
        let nextResult: number = 0;

        if (this._next != null && flag == true) {
            nextResult = this._next.handle(flag);
        } else {
            super.handle(flag);
        }

        return result + nextResult;
    }
}


// example
export class SomeService {
    constructor() { }

    public doSomething(): void {
        const afterHandler: AfterHandler = new AfterHandler(null);
        const beforeHandler: BeforeHandler = new BeforeHandler(afterHandler);

        const result: number = beforeHandler.handle(true);

        // returns before handler result
        // passes delegation onto the next handler
        // returns combined result of chained handlers
    }
}