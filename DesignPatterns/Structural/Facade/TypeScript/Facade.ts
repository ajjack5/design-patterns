export interface IComplexInterface {
    sendMessage(message: string): boolean;

    sendMessageAfterMinutes(message: string, minutes: number): boolean;
    sendMessageAfterSeconds(message: string, seconds: number): boolean;

    validateMessage(message: string): boolean;
    isMessageQueuedToSend(message: string): boolean;
}

export class ComplexClass implements IComplexInterface
{
    public isMessageQueuedToSend(message: string): boolean
    {
        // logic goes here
        return false;
    }

    public sendMessage(message: string): boolean
    {
        // logic goes here
        return true;
    }

    public sendMessageAfterMinutes(message: string, minutes: number): boolean
    {
        // logic goes here
        return true;
    }

    public sendMessageAfterSeconds(message: string, seconds: number): boolean
    {
        // logic goes here
        return true;
    }

    public validateMessage(message: string): boolean
    {
        // logic goes here
        return true;
    }
}

export class FacadeForComplexClass {
    private readonly _ComplexClass: IComplexInterface;

    public constructor(complexClass: IComplexInterface) {
        this._ComplexClass = complexClass;
    }

    // by using this object, we don't need to worry about all the internals
    // or the massive amounts of methods on the interface, just use this 1 implementation
    public send(message: string): boolean {
        const validatedMessage: boolean = this._ComplexClass.validateMessage(message);
        if (validatedMessage) {
            const isQueued: boolean = this._ComplexClass.isMessageQueuedToSend(message);
            if (!isQueued) {
                return this._ComplexClass.sendMessage(message);
            }
        }
        return false;
    }
}

// example
export class SomeService {
    constructor() { }

    public passSomethingToLayerBelow(message: string): void {
        const complexClass: IComplexInterface = new ComplexClass();
        const facade: FacadeForComplexClass = new FacadeForComplexClass(complexClass);

        const result: boolean = facade.send(message); // passes implementation to layer in the architecture below
    }
}