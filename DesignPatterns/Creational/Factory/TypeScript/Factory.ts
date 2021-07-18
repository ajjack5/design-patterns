export interface IProduct {
    someProperty: number | undefined;
}

export class ProductOne implements IProduct{
    someProperty: number | undefined = 10;
}

export class ProductTwo implements IProduct {
    someProperty: number | undefined = 20;
}

export class Factory {
    public CreateProduct(): IProduct | null {
        return null;
    }
}

export class ProductOneCreator implements Factory {
    public CreateProduct(): IProduct | null {
        return new ProductOne();
    }
}

export class ProductTwoCreator implements Factory {
    public CreateProduct(): IProduct | null {
        return new ProductTwo();
    }
}

// example
export class SomeService {
    public factory: Factory | undefined;

    constructor(flag: boolean) {
        if (flag) {
            this.factory = new ProductOneCreator();
        } else {
            this.factory = new ProductTwoCreator();
        }
    }

    public getProduct(): IProduct {
        return this.factory?.CreateProduct();
    }
}