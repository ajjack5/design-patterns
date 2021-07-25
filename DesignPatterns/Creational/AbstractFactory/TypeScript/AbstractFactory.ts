export interface IProductA {
    someProperty: number | undefined;
}

export interface IProductB {
    someDifferentProperty: number | undefined;
}

export interface IFactory1ProductA extends IProductA { }

export interface IFactory1ProductB extends IProductB { }

export interface IFactory2ProductA extends IProductA { }

export interface IFactory2ProductB extends IProductB { }


export interface IAbstractFactory {
    createProductA(): IProductA;
    createProductB(): IProductB;
}

export class Factory1 implements IAbstractFactory {

    public createProductA(): IProductA | null {
        return <IFactory1ProductA>{ someProperty: 42 };
    }

    public createProductB(): IProductB | null {
        return <IFactory1ProductB>{ someDifferentProperty: 99 };
    }
}

export class Factory2 implements IAbstractFactory {

    public createProductA(): IProductA | null {
        return <IFactory2ProductA>{ someProperty: 9000 };
    }

    public createProductB(): IProductB | null {
        return <IFactory2ProductB>{ someDifferentProperty: 5000 };
    }
}

// example
export class SomeService {
    public factory: IAbstractFactory | undefined;

    constructor(flag: boolean) {
        if (flag) {
            this.factory = new Factory1();
        } else {
            this.factory = new Factory2();
        }
    }

    public createProductA(): IProductA {
        return this.factory?.createProductA();
    }

    public createProductB(): IProductB {
        return this.factory?.createProductB();
    }
}