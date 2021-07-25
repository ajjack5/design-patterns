export interface IBuilder<T> {
    getInstance(): T;

    reset(): void;
    setSpecific(num: number): void;
    setOtherSpecific(num: number): void;
}

export interface Option {
    specificData: number;
}

export interface Question {
    specificData: number;
    otherSpecificData: number;
}

export class OptionBuilder implements IBuilder<Option>
{
    private _option: Option | undefined;

    constructor() {
        this._option = <Option>{};
    }

    public getInstance(): Option
    {
        return this._option;
    }

    public reset(): void
    {
        this._option = <Option>{};
    }

    public setSpecific(num: number): void
    {
        this._option.specificData = num + 500;
    }

    public setOtherSpecific(num: number): void
    {
        return;
    }
}

export class QuestionBuilder implements IBuilder<Question>
{
    private _question: Question | undefined;

    constructor() {
        this._question = <Question>{};
    }

    public getInstance(): Question {
        return this._question;
    }

    public reset(): void {
        this._question = <Question>{};
    }

    public setSpecific(num: number): void {
        this._question.specificData = num;
    }

    public setOtherSpecific(num: number): void {
        this._question.otherSpecificData = num;
    }
}

export class Director {

    constructor() { }

    public buildOption(): Option {
        const optionBuilder: IBuilder<Option> = new OptionBuilder();

        optionBuilder.reset();
        optionBuilder.setSpecific(42);

        return optionBuilder.getInstance();
    }

    public BuildQuestion(): Question {
        const questionBuilder: IBuilder<Question> = new QuestionBuilder();

        questionBuilder.reset();
        questionBuilder.setSpecific(45);
        questionBuilder.setOtherSpecific(66);

        return questionBuilder.getInstance();
    }
}

// example
export class SomeService {
    public flag: boolean;

    public getDecision(): any { // could also extract a common interface here too
        const director: Director = new Director();
        let result: any;

        if (this.flag) {
            result = director.buildOption();
        } else {
            result = director.BuildQuestion();
        }

        return result;
    }
}