### Step 2 : what is the same between the two stores, and what is different?
- Two is the same in 90% of code lines, there is small differences (Type, Variable Names)

### step 3:  GetById will not compile
- will not compile because the compiler cannot sure that T have Id inside it, it can be int, ...
- the fix is set where keyword, builing interface have Id and any T should implement this interface.