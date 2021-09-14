export interface IOriginalService {
    someOperation(): boolean;
}

export class OriginalService implements IOriginalService {

    constructor() { }

    public someOperation(): boolean {
        return true;
    }
}

export class Proxy implements IOriginalService {

    constructor(private _originalService: IOriginalService) { }

    public someOperation(): boolean {
        return this._originalService.someOperation();
    }
}


// example
export class SomeService {
    public originalService: IOriginalService = new OriginalService();
    public proxyService: IOriginalService = new Proxy(this.originalService);

    constructor() { }

    public doSomething(): void {
        const result: boolean = this.proxyService.someOperation(); // calls the original service via a proxy
        // do... 
    }
}