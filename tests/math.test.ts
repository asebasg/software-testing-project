import { sum } from "../utils/math";
import { expect, describe, it } from "@jest/globals";

describe("sum", () => {
  it("should return the sum of two numbers", () => {
    expect(sum(2, 3)).toBe(5);
  });

  it("should return -1 hwne adding -3 and 2", () => {
    expect(sum(-3, 2)).toBe(-1);
  });
});
