export interface IComponent {
    execute(): string;
}

export class Component implements IComponent
{
    public execute(): string {
        return "[[original implementation]]";
    }
}

export abstract class BaseDecorator implements IComponent
{
    protected _wrapper: IComponent;

    // inject original object
    protected constructor(component: IComponent)
    {
        this._wrapper = component;
    }

    // delegate original implementation
    public execute(): string
    {
        if (this._wrapper == null) {
            return null;
        }

        return this._wrapper.execute();
    }
}

export class ChildDecorator extends BaseDecorator
{
    constructor(component: IComponent) {
        super(component);
    }

    // wrap original implementation
    public execute(): string
    {
        return "[[child decorated]]" + super.execute();
    }
}

// example
export class SomeService {
    constructor() { }

    public doSomething(): void {
        const component: IComponent = new Component();
        const componentWithAdditionalBehaviour: IComponent = new ChildDecorator(component);

        const result: string = componentWithAdditionalBehaviour.execute();
        // returns [[child decorated]][[original implementation]]
    }
}