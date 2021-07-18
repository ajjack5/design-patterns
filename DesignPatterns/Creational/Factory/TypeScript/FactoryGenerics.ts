export interface IFruit {
    colour: string;
}

export class Apple implements IFruit {
    colour = 'Red';
}

export class Banana implements IFruit {
    colour = 'Yellow';
}

export interface IFruitFactory {
    getFruit<T>(fruit: T): IFruit | null;
}

export class FruitFactory implements IFruitFactory {
    getFruit<T>(fruit: T): IFruit | null {

        if ((typeof fruit) === typeof Apple) {
            return new Apple();
        }

        if ((typeof fruit) === typeof Banana) {
            return new Banana();
        }

        return null;
    }
}

// example
export class SomeService {
    public getFruit(): IFruit {
        const factory: IFruitFactory = new FruitFactory();

        return factory.getFruit(Banana);
    }
}